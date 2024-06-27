import {LoginForm} from '../FormComponents/LoginForm';
import './styles/HomeStyle.css';
import {Header} from './Header';


export const Home = () => {
    return (
        <main id="home_main_container">
            <Header></Header>
            <LoginForm></LoginForm>
        </main>
    )
}