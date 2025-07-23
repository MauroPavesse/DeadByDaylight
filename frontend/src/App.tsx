import './App.css'
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import RuletaPage from './pages/RuletaPage';

const App: React.FC = () => {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<RuletaPage />} />
        {/* Podés agregar más rutas en el futuro */}
      </Routes>
    </Router>
  );
};

export default App
