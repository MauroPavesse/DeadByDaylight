import axios from 'axios';

const api = axios.create({
  baseURL: import.meta.env.VITE_API_URL || 'http://localhost:5227/api',
  //baseURL: import.meta.env.VITE_API_URL || 'https://www.backend-gies-go.etheralink.online/api',
});

export default api