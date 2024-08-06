import { FormEvent, useState } from 'react';
import LoginFormStyle from '../styles/LoginFormStyle.module.css';


interface RegistrationData{
    Username: string;
    Password: string;
    RoleId: number;
 
}
const RegistrationForm:React.FC = () => {

    const [ registrationData, setRegistrationData ] = useState<RegistrationData>({
        Username: "",
        Password: "",
        RoleId: 0
    });

    const [notification, setNotification] = useState(null);

    const handleRegisterFormSubmission = (e:FormEvent<HTMLFormElement>) =>{
        e.preventDefault();
        console.log(registrationData);
        fetch('http://localhost:5094/api/User/CreateUser', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(registrationData)
        })
        .then(response => response.text())
        .then(data=> {
            setNotification(data);
            setTimeout(() => {
                setNotification(null);
            }, 3000)
        })
        .catch(error => setNotification(error));
    }

    return(
        <form  className={LoginFormStyle.loginForm} onSubmit={handleRegisterFormSubmission}>
            {
                notification && (<p>{notification}</p>)
            }
            
            <label>Username:</label>
            <input type="text" onChange={(e) => setRegistrationData(prev => ({...prev, Username: e.target.value}))}required value={registrationData.username}></input>
            
            <label>Password:</label>
            <input type="password" required onChange={(e) => setRegistrationData(prev => ({...prev, Password: e.target.value}))}  value={registrationData.password}></input>
        
            <label>Role Id:</label>
            <input type="number" required min="1" max="3" onChange={(e) => setRegistrationData(prev => ({...prev, RoleId: parseInt(e.target.value)}))}  value={registrationData.roleId}></input>

            <input type="submit" value = "Register" />
        
        </form>
    )
}

export default RegistrationForm;