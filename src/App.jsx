import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import LoginScreen from './LoginScreen'
import HomePage from './HomePage'
import RegistratieScreen from './RegistratieScreen'
import { BrowserRouter, Routes, Route} from 'react-router-dom'


function App() {

  return (
    <>
      <BrowserRouter>
        <Routes>
          <Route index element={<HomePage/>}/>
          <Route path="/home" element={<HomePage/>}/>
          <Route path="/login" element={<LoginScreen/>}/>
          <Route path="/register" element={<RegistratieScreen/>}/>
        </Routes>
      </BrowserRouter>
    </>
  )
}

export default App
