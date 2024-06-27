import { useState } from "react";
import "./styles/LoginFormStyle.css";
import { useNavigate } from "react-router-dom";


interface FormData{
    username: string;
    password: string;
}


export const LoginForm = () =>  {

    const[error, setError] = useState("");
    const navigate = useNavigate();


    const handleLogin = (e:any) => {
        e.preventDefault();
        const updatedFormData:FormData = {
            username: e.currentTarget.elements.username.value,
            password: e.currentTarget.elements.password.value
        }

        //Create a fetch call to the server

        const response =  fetch('http://localhost:5094/api/User/AuthenticateUser', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(updatedFormData) // -- converts object FormData object to jason string
            //"{"username":"john_doe","password":"password123"}"
        })
        .then(res => res.text()) // convert to json
        .then(data => {
            if(data === "Success"){
                console.log(data)
                navigate("/dashboard");
            }
            else{
                setError("Invalid username or password")
                setTimeout(() => {setError("")}, 2000)
            }
    
        });


    }


    return(
        <form id="loginForm" onSubmit={handleLogin}>
            <h1>Log In </h1>
            {error? <p className="errors-login">Login failed!</p>:null}
            <label>Username</label>
            <input type="text" placeholder="jhondoe456" required name="username"/>
            <label>Password</label>
            <input type="password" placeholder="•••••••" required name="password"/>
            <input type="submit" value="Log In" className="submitBtn" />
        </form>
    )
}