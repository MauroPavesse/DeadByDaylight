import React, { useEffect, useState } from 'react';
import Rodillo from './Rodillo';
import ventajas from '../../data/ventajas.json';

const SlotMachine: React.FC = () => {
  const rodillos = 4;
  const [symbols, setSymbols] = useState<string[]>(Array(rodillos).fill('❔'));
  const [spinning, setSpinning] = useState(false);
  const [peks, setPeks] = useState<typeof ventajas>([]);

  useEffect(() => {
    setPeks(ventajas);
  }, []);

  const getRandomSymbol = (): string => {
    if (peks.length === 0) return '❔';
    return peks[Math.floor(Math.random() * peks.length)].Imagen;
  };

  const spin = () => {
    if (spinning || peks.length === 0) return;

    setSpinning(true);

    const newSymbols = Array.from({ length: rodillos }, () => getRandomSymbol());
    setSymbols(newSymbols);

    setTimeout(() => {
      setSpinning(false);
    }, 2000);
  };

  return (
    <div style={{ textAlign: 'center', marginTop: '50px' }}>
      {/*<h1>🎰 Tragamonedas Ventajas</h1>*/}
      <h1>Ventajas aleatorias</h1>
      <div style={{ display: 'flex', justifyContent: 'center', marginBottom: '20px' }}>
        {symbols.map((symbol, index) => (
          <Rodillo
            key={index}
            isSpinning={spinning}
            finalSymbol={symbol}
            delay={1000 + index * 300}
            peks={peks} // ← pasás los símbolos reales a cada rodillo
          />
        ))}
      </div>
      <button onClick={spin} disabled={spinning || peks.length === 0}>
        {spinning ? 'Girando...' : 'Girar'}
      </button>
    </div>
  );
};

export default SlotMachine;
