// src/components/SlotMachine/symbols.ts
export const symbols = ['🍒', '🍋', '🍊', '⭐', '💎', '🔔'];

export const getRandomSymbol = (): string =>
  symbols[Math.floor(Math.random() * symbols.length)];
