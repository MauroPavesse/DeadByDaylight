import api from "./api";

export type VentajaResponse = {
  id: number,
  nombre: string,
  imagen: string
}

export type ApiResponse<T> = {
  data: T | null,
  success: boolean
}

const obtenerVentajas = async (): Promise<VentajaResponse[]> => {
  const { data } = await api.post<ApiResponse<VentajaResponse[]>>('/ventajas/buscar', {})
  console.log(data);
  return data.data!;
}

export default {
  obtenerVentajas
}
