import React, { useState } from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import Login from './pages/Login';
import Register from './pages/Register';

function App() {
    const [isRegistering, setIsRegistering] = useState(false);

    return (
        <div>
            <h1 align= "center">Welcome to TaxiApp!</h1>
            {isRegistering ? (
                <Register onLoginClick={() => setIsRegistering(false)} />
            ) : (
                <Login onRegisterClick={() => setIsRegistering(true)} />
            )
        }
        </div>
    );
}

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(<App />);
