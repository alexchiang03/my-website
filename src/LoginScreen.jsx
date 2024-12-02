import './LoginScreen.css'
import { useNavigate } from 'react-router-dom'
function LoginScreen(){
  const navigate = useNavigate();
  return(
    <div className="wrapper">
      <form action="">
      <h1>Login</h1>
      <div className='input-box'>
       <input type= "text" placeholder="E-mail" required></input>
      </div>
      <div className='input-box'>
       <input type= "password" placeholder="Wachtwoord" required></input>
      </div>
      <div className="remember-forgot">
        <label><input type="checkbox" />Gegevens onthouden &nbsp;</label>
        <a href="#"> Wachtwoord vergeten?</a>
      </div>
      <button onClick={() => navigate('/home', {replace: true})} className='login-button'>Submit</button>
      </form>
    </div>
  )
}
export default LoginScreen