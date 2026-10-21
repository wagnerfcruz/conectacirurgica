import React, { useEffect, useRef, useState } from 'react';

interface Props {
  children: React.ReactNode;
  originalWidth?: number;
  originalHeight?: number;
}

export default function CardResponsiveWrapper({ children, originalWidth = 700, originalHeight = 1180 }: Props) {
  const containerRef = useRef<HTMLDivElement>(null);
  const [scale, setScale] = useState(0.5); // Default start scale

  useEffect(() => {
    const observer = new ResizeObserver((entries) => {
      if (entries[0]) {
        const width = entries[0].contentRect.width;
        setScale(width / originalWidth);
      }
    });
    
    if (containerRef.current) {
      observer.observe(containerRef.current);
    }
    
    return () => observer.disconnect();
  }, [originalWidth]);

  return (
    <div 
      ref={containerRef} 
      className="w-full relative overflow-hidden" 
      style={{ aspectRatio: `${originalWidth}/${originalHeight}` }}
    >
      <div style={{ transform: `scale(${scale})`, transformOrigin: 'top left', width: originalWidth, height: originalHeight, position: 'absolute', top: 0, left: 0 }}>
        {children}
      </div>
    </div>
  );
}
