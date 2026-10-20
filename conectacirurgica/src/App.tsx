import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom';
import InstrumentadorLayout from './components/layout/InstrumentadorLayout';
import CoordenadoraLayout from './components/layout/CoordenadoraLayout';
import Login from './pages/Login';

// Instrumentador Pages
import DashboardInstrumentador from './pages/instrumentador/Dashboard';
import Disponibilidade from './pages/instrumentador/Disponibilidade';
import Historico from './pages/instrumentador/Historico';

// Coordenadora Pages
import DashboardCoordenadora from './pages/coordenadora/Dashboard';
import PesquisaDisponibilidade from './pages/coordenadora/PesquisaDisponibilidade';
import MapaCirurgico from './pages/coordenadora/MapaCirurgico';
import Acionamentos from './pages/coordenadora/Acionamentos';
import Confirmados from './pages/coordenadora/Confirmados';
import Profissionais from './pages/coordenadora/Profissionais';
import Documentos from './pages/coordenadora/Documentos';

function App() {
  return (
    <Router basename="/conectacirurgica">
      <Routes>
        <Route path="/" element={<Login />} />
        
        {/* Instrumentador Routes */}
        <Route path="/instrumentador" element={<InstrumentadorLayout />}>
          <Route index element={<DashboardInstrumentador />} />
          <Route path="disponibilidade" element={<Disponibilidade />} />
          <Route path="historico" element={<Historico />} />
        </Route>

        {/* Coordenadora Routes */}
        <Route path="/coordenadora" element={<CoordenadoraLayout />}>
          <Route index element={<DashboardCoordenadora />} />
          <Route path="disponibilidade" element={<PesquisaDisponibilidade />} />
          <Route path="mapa" element={<MapaCirurgico />} />
          <Route path="acionamentos" element={<Acionamentos />} />
          <Route path="confirmados" element={<Confirmados />} />
          <Route path="profissionais" element={<Profissionais />} />
          <Route path="documentos" element={<Documentos />} />
        </Route>

        <Route path="*" element={<Navigate to="/" replace />} />
      </Routes>
    </Router>
  );
}

export default App;
