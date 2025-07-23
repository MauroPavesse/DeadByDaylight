import React, { createContext, useContext } from 'react'
import type { VentajaResponse } from '../services/vantajaService'
import ventajaService from '../services/vantajaService'

export type VentajaContextType = {
  obtenerVentajas: () => Promise<VentajaResponse[]>
}

const VentajaContext = createContext<VentajaContextType>({
  obtenerVentajas: async () => ([{
    id: 0,
    nombre: '',
    imagen: ''
  }])
})

type VentajaProviderProps = {
  children: React.ReactNode
}

export const VentajaProvider: React.FC<VentajaProviderProps> = ({ children }) => {

    const obtenerVentajas = async () => {
      var datos = await ventajaService.obtenerVentajas();
      return datos;
    }

    return (
        <VentajaContext.Provider
            value={{ obtenerVentajas }}
        >
            {children}
        </VentajaContext.Provider>
    )
}

export const useVentaja = () => useContext(VentajaContext)

export default VentajaContext
