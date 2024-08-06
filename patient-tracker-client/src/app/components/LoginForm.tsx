import LoginFormStyle from '../styles/LoginFormStyle.module.css';
import { useState, useContext } from 'react';
import UserContext  from '../UserContext';
export function LoginForm():React.FC{

    const { setUsername } = useContext(UserContext);
    const [inputUsername, setInputUsername] = useState('');


    const handleFormSubmission = (e) => {
        e.preventDefault();
        setUsername(inputUsername);
    }

    return(
            <form className={LoginFormStyle.loginForm} onSubmit={handleFormSubmission}>
                <h2>Login</h2>
                    <label>Username:</label>
                    <input type="text" onChange={(e) => setInputUsername(e.target.value)} required placeholder="Type your username..." value={inputUsername}></input>

                    <label>Password:</label>
                    <input type="password" required></input>

                    <input type="submit" value = "Login" />               
            </form>
    )
}