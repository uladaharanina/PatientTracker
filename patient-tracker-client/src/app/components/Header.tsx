import { useState } from 'react';
import HeaderStyle from '../styles/HeaderStyle.module.css';
import { UserInfo } from './UserInfo';

interface UserInfoData{
    username: string;
    onLogout: () => void; // Callback function
    onLogin: () => void; // Callback function
}

export const Header:React.FC<UserInfoData> = (props) => {
    
    const [isUserLogged, setUserLogingStatus] = useState(true);

    const handleUserStatus: React.MouseEventHandler<HTMLButtonElement> = (event) => {
        event.preventDefault();
        if(isUserLogged){
            props.onLogout();
            setUserLogingStatus(false);
        }
        else{
            props.onLogin();
            setUserLogingStatus(true);
        }

      };

    return(
        <header>
            <UserInfo username={props.username}></UserInfo>
            <nav id={HeaderStyle.nav}>
                <ul>
                    <li>Home</li>
                    <li>About</li>
                    <li>Contacts</li>
                </ul>
             
            </nav>
            <button onClick={handleUserStatus}> {isUserLogged? "Logout": "Login"}</button>
        </header>
    )
}