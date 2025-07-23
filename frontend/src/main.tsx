import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.tsx'
import React from 'react'
import { VentajaProvider } from './context/VentajaContexto.tsx'

createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <VentajaProvider>
      <App />
    </VentajaProvider>
  </React.StrictMode>
)
