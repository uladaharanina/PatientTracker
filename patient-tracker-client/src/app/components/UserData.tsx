'use client'

import { useState, useContext } from "react";
import  UserContext  from "../UserContext";
import HeaderStyle from '../styles/HeaderStyle.module.css';


// One line props passing
export const UserData = () => {
    const { username } = useContext(UserContext);

    return(
        <div id={HeaderStyle.userDataContainer}>
             <h3>Welcome, {username}</h3>
        </div>
       
    )
}