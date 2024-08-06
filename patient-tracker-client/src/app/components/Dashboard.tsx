import { useContext, useEffect, useState } from "react"
import UserContext from "../UserContext";

interface User{
    username: string,
    roleId:number
}

type UserList = User[];

export const Dashboard = () => {

    const [userList, setUserList] = useState<UserList>([]);
    const { username, setUsername } = useContext(UserContext);
    const [notification, setNotification] = useState(null);

    useEffect(() => {
        fetch('http://localhost:5094/api/User/ListAllUsers', {
            method:'GET',
            headers: {
                'Content-Type': 'application/json',
            }
        })
        .then(response => response.json())
        .then(data => {
            setUserList(data);
            console.log(data)
        })
    },[])


    const deleteUser = (index:number) => () => {
      
        fetch(`http://localhost:5094/api/User/Delete/${index}`, {
            method:'DELETE',
            headers: {
                'Content-Type': 'application/json',
            }
        })
        .then(response => response.text())
        .then(data => {
            console.log(data)
        })
    }

    return (
        <div>
            <h1>Welcome, {username}!</h1>
            
            <h3>Here is the list of all current users</h3>
            {
                notification && (<p>{notification}</p>)
            }
            <ul>
              {
                userList.map((user) => {
                    return <li key={user.username}>{user.username} <button onClick={deleteUser(index)}>Delete user</button></li>
                })
              }
            </ul>
        </div>
    )
}