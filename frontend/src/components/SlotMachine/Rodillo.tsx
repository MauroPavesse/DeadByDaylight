import React, { useEffect, useState } from 'react';
import './Rodillo.css';

interface Ventaja {
  Id: number;
  Nombre: string;
  Descripcion: string;
  RolId: number;
  Imagen: string;
}

interface RodilloProps {
  isSpinning: boolean;
  finalSymbol: string;
  delay: number;
  peks: Ventaja[];
}

const Rodillo: React.FC<RodilloProps> = ({ isSpinning, finalSymbol, delay, peks }) => {
  const [currentSymbols, setCurrentSymbols] = useState<string[]>([]);
  const [stopped, setStopped] = useState(false);

  useEffect(() => {
    if (isSpinning && peks.length > 0) {
      setStopped(false);

      const interval = setInterval(() => {
        const randoms = Array.from({ length: 20 }, () =>
          peks[Math.floor(Math.random() * peks.length)].Imagen
        );
        setCurrentSymbols(randoms);
      }, 100);

      const timeout = setTimeout(() => {
        clearInterval(interval);
        setCurrentSymbols([finalSymbol]); // este debe ser el nombre del archivo .png
        setStopped(true);
      }, delay);

      return () => {
        clearInterval(interval);
        clearTimeout(timeout);
      };
    }
  }, [isSpinning, finalSymbol, delay, peks]);

  return (
    <div className="rodillo">
      <div className={`contenido ${stopped ? 'stopped' : 'spinning'}`}>
        {currentSymbols.map((symbol, i) => {
          const ventaja = peks.find(p => p.Imagen === symbol);
          return (
            <div key={i} className="simbolo">
              <img
                src={`/images/${symbol}`}
                alt={ventaja?.Nombre || 'símbolo'}
                title={ventaja?.Nombre || ''}
                style={{ width: '60px', height: '60px', objectFit: 'contain' }}
              />
            </div>
          );
        })}
      </div>
    </div>
  );
};

export default Rodillo;
