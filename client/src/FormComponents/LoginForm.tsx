import "./styles/LoginFormStyle.css"

export const LoginForm = () =>  {
    return(
        <form id="loginForm">
            <h1>Login </h1>
            <label>Username</label>
            <input type="text" placeholder="jhondoe456"/>
            <label>Password</label>
            <input type="password" placeholder="•••••••"/>
            <input type="submit" value="Login" className="submitBtn"/>
        </form>
    )
}