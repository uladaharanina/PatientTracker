'use client';
import { useState, useContext, useEffect } from "react";
import  UserContext  from "../UserContext";
import { UserData } from "./UserData"
import HeaderStyle from '../styles/HeaderStyle.module.css';
import Link from "next/link";

interface HeaderProps{
    onLogout: () => void;
}

export const Header:React.FC<HeaderProps> = (props) => {

    const { username, setUsername } = useContext(UserContext);
    const [isUserLogged, setUserLoginStatus] = useState(username != "User");

     // useEffect updates isUserLogged whenever username changes. 
     //This ensures that the state reflects the current value of username correctly.
     useEffect(() => {
        setUserLoginStatus(username !== "User");
    }, [username]); // The dependency array [username] ensures that the effect runs only when username changes.
    
    const onLogout = ()  => {
        setUsername("User");
        setUserLoginStatus(false);
    }
    return(
        <header id={HeaderStyle.header}>
            <UserData></UserData>
            <nav>
                <ul>
                    {isUserLogged}
                    <li className={HeaderStyle.li}><Link href="/">Home</Link></li>
                    <li className={HeaderStyle.li}><Link href="/about">About</Link></li>
                    <li className={HeaderStyle.li}>Contacts</li>
                </ul>
            </nav>
            
             {/* Conditional rendering */}
             {isUserLogged && (
                <button onClick={onLogout}>Logout</button>
            )}
            
        </header>
    )
}
