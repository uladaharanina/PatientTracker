import React from "react"

interface GreetingInfo{
    username:string;
}

export const UserInfo: React.FC<GreetingInfo> = ({username}) => {

    return(
        <section>
            <>Welcome, {username}</>
        </section>
    )
}