import { useNavigate } from "react-router-dom"

function RegistratieScreen(){
  const navigate = useNavigate();
  return(
    <div className="wrapper">
      <form action="">
      <h1>Regie</h1>
      <div className='input-box'>
       <input type= "text" placeholder="E-mail" required></input>
      </div>
      <div className='input-box'>
       <input type= "password" placeholder="Adres" required></input>
      </div>
      <div className='input-box'>
       <input type= "text" placeholder="Telefoon nummer" required></input>
      </div>
      <div className='input-box'>
       <input type= "password" placeholder="Wachtwoord" required></input>
      </div>
      <div className='input-box'>
       <input type= "password" placeholder="Confirm wachtwoord" required></input>
      </div>
      <button onClick={() => navigate('/home', {replace: true})} className='login-button'>Submit</button>
      </form>
    </div>
  )
}
export default RegistratieScreen