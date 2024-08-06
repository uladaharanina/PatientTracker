'use client';

import Image from "next/image";
import styles from "./page.module.css";
import { UserData } from "./components/UserData";
import { useContext } from "react";
import { LoginForm } from "./components/LoginForm";
import { Dashboard } from "./components/Dashboard";
import { Header } from "./components/Header";
import UserContext from "./UserContext";
import RegistrationForm from "./components/RegistrationForm";



export default function Home() {
  const { username, setUsername } = useContext(UserContext);

  //Use Context Hook

//allows functional components to access context values 
//without having to pass props manually through each level of the component tree. 

  const handleLogOut = () => {
    setUsername("User");
  }

  return (
    <>

      <Header onLogout={handleLogOut} ></Header>
      
      {
        username === "User" ? <LoginForm></LoginForm> : <Dashboard></Dashboard>
      }
    
    </>
  );
}
