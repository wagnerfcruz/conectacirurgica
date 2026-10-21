import React, { useEffect, useRef, useState } from 'react';

interface Props {
  children: React.ReactNode;
  originalWidth?: number;
}

export default function CardResponsiveWrapper({ children, originalWidth = 700 }: Props) {
  const containerRef = useRef<HTMLDivElement>(null);
  const contentRef = useRef<HTMLDivElement>(null);
  const [scale, setScale] = useState(0.5); // Default start scale
  const [height, setHeight] = useState(1180);

  useEffect(() => {
    const observer = new ResizeObserver((entries) => {
      for (let entry of entries) {
        if (entry.target === containerRef.current) {
          const width = entry.contentRect.width;
          setScale(width / originalWidth);
        }
        if (entry.target === contentRef.current) {
          setHeight(entry.contentRect.height);
        }
      }
    });
    
    if (containerRef.current) observer.observe(containerRef.current);
    if (contentRef.current) observer.observe(contentRef.current);
    
    return () => observer.disconnect();
  }, [originalWidth]);

  return (
    <div 
      ref={containerRef} 
      className="w-full relative overflow-hidden" 
      style={{ height: height * scale }}
    >
      <div 
        ref={contentRef}
        style={{ transform: `scale(${scale})`, transformOrigin: 'top left', width: originalWidth, position: 'absolute', top: 0, left: 0 }}
      >
        {children}
      </div>
    </div>
  );
}
