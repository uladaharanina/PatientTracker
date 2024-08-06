'use client';
import { useState, useContext } from "react";
import { UserContext } from "../UserContext";
import { UserData } from "./UserData"
import HeaderStyle from '../styles/HeaderStyle.module.css';

interface HeaderProps{
    onLogout: () => void;
}

export const Header:React.FC<HeaderProps> = (props) => {

    const [isUserLogged, setUserLoginStatus] = useState(true);

    const handleUserLoging = () =>{

        if(isUserLogged){
            setUserLoginStatus(false);
            props.onLogout();
            
        }
    }

    return(
        <header id={HeaderStyle.header}>
            <UserData></UserData>
            <nav>
                <ul>
                    <li className={HeaderStyle.li}>Home</li>
                    <li className={HeaderStyle.li}>About</li>
                    <li className={HeaderStyle.li}>Contacts</li>
                </ul>
            </nav>
            
            <button onClick={handleUserLoging}>{isUserLogged ? "Logout": "Login"}</button>
        </header>
    )
}
