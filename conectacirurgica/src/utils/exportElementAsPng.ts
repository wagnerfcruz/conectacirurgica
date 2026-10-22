import html2canvas from 'html2canvas';

const MODERN_COLOR_FN_REGEX = /(oklch|oklab|color-mix|lch|lab|hwb|color)\s*\(/i;
const MODERN_COLOR_FN_START_REGEX = /(oklch|oklab|color-mix|lch|lab|hwb|color)\s*\(/gi;

const COLOR_PROPERTIES = [
  'background-color',
  'color',
  'border-top-color',
  'border-right-color',
  'border-bottom-color',
  'border-left-color',
  'text-decoration-color',
  '-webkit-text-stroke-color',
  'outline-color',
  'box-shadow',
  'text-shadow',
  'background-image',
  'fill',
  'stroke',
];

function createColorConverter(): (cssColor: string) => string {
  const canvas = document.createElement('canvas');
  canvas.width = 1;
  canvas.height = 1;
  const ctx = canvas.getContext('2d', { willReadFrequently: true });
  const cache = new Map<string, string>();

  return (cssColor: string): string => {
    const key = cssColor.trim();
    const cached = cache.get(key);
    if (cached) return cached;

    if (!ctx) return 'rgb(0, 0, 0)';

    try {
      ctx.clearRect(0, 0, 1, 1);
      ctx.fillStyle = 'rgba(0, 0, 0, 0)';
      ctx.fillStyle = key;
      ctx.fillRect(0, 0, 1, 1);
      const [r, g, b, a] = ctx.getImageData(0, 0, 1, 1).data;
      let result: string;
      if (a === 0) {
        result = 'rgba(0, 0, 0, 0)';
      } else if (a === 255) {
        result = `rgb(${r}, ${g}, ${b})`;
      } else {
        result = `rgba(${r}, ${g}, ${b}, ${(a / 255).toFixed(3)})`;
      }
      cache.set(key, result);
      return result;
    } catch {
      return 'rgb(0, 0, 0)';
    }
  };
}

export function replaceModernColorFunctions(
  input: string,
  toRgb: (color: string) => string
): string {
  if (!input || !MODERN_COLOR_FN_REGEX.test(input)) {
    return input;
  }

  let output = '';
  let lastIndex = 0;
  MODERN_COLOR_FN_START_REGEX.lastIndex = 0;
  let match: RegExpExecArray | null;

  while ((match = MODERN_COLOR_FN_START_REGEX.exec(input)) !== null) {
    const startIdx = match.index;
    if (startIdx < lastIndex) continue;

    output += input.slice(lastIndex, startIdx);

    let depth = 0;
    let i = startIdx;
    for (; i < input.length; i++) {
      const ch = input[i];
      if (ch === '(') depth++;
      else if (ch === ')') {
        depth--;
        if (depth === 0) {
          i++;
          break;
        }
      }
    }

    const fnCall = input.slice(startIdx, i);
    output += toRgb(fnCall);
    lastIndex = i;
    MODERN_COLOR_FN_START_REGEX.lastIndex = i;
  }

  output += input.slice(lastIndex);
  return output.replace(
    /\bin\s+(?:oklab|oklch|srgb|srgb-linear|display-p3|hsl|hwb|lab|lch|xyz)\s*,?\s*/gi,
    ''
  );
}

export async function exportElementAsPng(
  element: HTMLElement,
  filename: string,
  backgroundColor: string = '#11223F'
): Promise<void> {
  const toRgb = createColorConverter();

  const canvas = await html2canvas(element, {
    scale: 2,
    backgroundColor,
    useCORS: true,
    allowTaint: false,
    logging: false,
    onclone: (clonedDoc, clonedEl) => {
      // 1. Posicionar elemento clonado de forma visível em (0, 0) dentro do iframe clonado
      let parent = clonedEl.parentElement;
      while (parent && parent !== clonedDoc.body && parent !== clonedDoc.documentElement) {
        const inlinePos = parent.style.position;
        if (inlinePos === 'fixed' || inlinePos === 'absolute') {
          parent.style.position = 'static';
          parent.style.left = '0';
          parent.style.top = '0';
          parent.style.zIndex = 'auto';
          parent.style.opacity = '1';
          parent.style.visibility = 'visible';
        }
        parent = parent.parentElement;
      }

      // 2. Remover imagens quebradas ou ocultas para evitar falha de carregamento no html2canvas
      clonedEl.querySelectorAll('img').forEach((img) => {
        if (img.style.display === 'none' || (img.complete && img.naturalWidth === 0)) {
          img.remove();
        }
      });

      // 3. Converter funções de cor modernas (oklch, oklab, color-mix, etc.) nas folhas <style>
      clonedDoc.querySelectorAll('style').forEach((styleEl) => {
        if (styleEl.textContent && MODERN_COLOR_FN_REGEX.test(styleEl.textContent)) {
          styleEl.textContent = replaceModernColorFunctions(styleEl.textContent, toRgb);
        }
      });

      // 4. Sanitizar estilos inline e estilos computados no documento clonado
      const win = clonedDoc.defaultView;
      const elements: Element[] = [
        clonedDoc.documentElement,
        clonedDoc.body,
        clonedEl,
        ...Array.from(clonedEl.querySelectorAll('*')),
      ].filter(Boolean);

      for (const el of elements) {
        const htmlOrSvg = el as HTMLElement | SVGElement;
        if (!htmlOrSvg.style) continue;

        const inlineStyle = el.getAttribute('style');
        if (inlineStyle && MODERN_COLOR_FN_REGEX.test(inlineStyle)) {
          el.setAttribute('style', replaceModernColorFunctions(inlineStyle, toRgb));
        }

        if (win) {
          const computed = win.getComputedStyle(el);
          for (const prop of COLOR_PROPERTIES) {
            const val = computed.getPropertyValue(prop);
            if (val && MODERN_COLOR_FN_REGEX.test(val)) {
              const converted = replaceModernColorFunctions(val, toRgb);
              htmlOrSvg.style.setProperty(prop, converted, 'important');
            }
          }
        }
      }
    },
  });

  const dataUrl = canvas.toDataURL('image/png');
  const link = document.createElement('a');
  link.href = dataUrl;
  link.download = filename.endsWith('.png') ? filename : `${filename}.png`;
  document.body.appendChild(link);
  link.click();
  document.body.removeChild(link);
}
