import React, { useEffect, useState } from 'react'
import "./styles/UserDashboardStyle.css"
interface Users{
    username:string,
    roleId: number
}

const UserDashboard = () => {

  const [users, setUserList] = useState<Users[]>([]);

  useEffect(() => {
    fetch("http://localhost:5094/api/user/ListAllUsers", {
        method:'GET',
        headers: {
            'Content-Type': 'application/json',
        }
    })
    .then(resposne => resposne.json())
    .then(data => setUserList(data))
  },[])  

  return (
    <section id="admin-layout-container">
      <h1>Welcome, User</h1>

      <div>
        <h2>Lists of users</h2>
        <ul>
          <div className="title-container">
            <li>Username </li>
            <li> Role</li>
          </div>
        {
          users.map((user,index) =>(
            <li key={index}>{user.username} {user.roleId} </li>
          ))
        }
        </ul>
      </div>
    </section>
  )
}

export default UserDashboard
