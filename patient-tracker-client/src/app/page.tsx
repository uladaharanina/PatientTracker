'use client';
import Image from "next/image";
import styles from "./page.module.css";
import { UserInfo } from "./components/UserInfo";
import {Header} from "./components/Header";
import { useState } from "react";
import { Footer } from "./components/Footer";


export default function Home() {
  const [username, setUsername] = useState("Vlada");

  const handleLogOut = () => {
    setUsername("User");
  }

  const handleLogIn = () =>{
    setUsername("Vlada");
  }

  return (
    <main className={styles.main}>
      {
      /* Props
      Pass our data from parent component to child component
      */
      } 
        <Header username={username} onLogout={handleLogOut} onLogin={handleLogIn}></Header>
        
        {
          username == "Vlada" ? <p>User logged in</p>:<p>User logged out</p> 
        }


        <Footer></Footer>
      </main>
  );
}
