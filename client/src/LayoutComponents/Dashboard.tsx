import UserDashboard from "../UserComponents/UserDashboard"
import { Header } from "./Header"

export const Dashboard = () => {

    //Get roleID

    return (
        <main>
            <Header />
            <UserDashboard></UserDashboard>
        </main>
    )
}