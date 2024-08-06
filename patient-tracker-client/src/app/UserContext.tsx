"use client";

import { createContext, useContext, useState } from 'react';
const UserContext = createContext(null); // provide a default context

export const UserProvider = ({ children }) => {
    const [username, setUsername] = useState('User');

    return (
        <UserContext.Provider value={{ username, setUsername }}>
            {children}
        </UserContext.Provider>
    );
}

export default UserContext;