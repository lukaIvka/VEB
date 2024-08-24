import React, { useState } from 'react';
import '../styles/Login.css';

function Login({ onRegisterClick }) {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');

    const handleLogin = async (e) => {
        e.preventDefault();
        // Ovdje dodaj logiku za login

        const loginData = {
            email,
            password
        };
        if (!email || !password) {
            alert('Molimo unesite i email i lozinku.');
            return;
        }
    
        const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        if (!emailRegex.test(email)) {
            alert('Unesite ispravan email.');
            return;
        }
        try {
            const response = await fetch('http://localhost:5000/api/auth/login', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(loginData)
            });
            if (response.ok) {
                const data = await response.json();
            console.log('Login successful:', data);
            // Ovdje možeš obraditi dobijene podatke, kao što je čuvanje tokena ili preusmeravanje korisnika
        } else {
            console.log('Login failed:', response.statusText);
            // Ovdje možeš obraditi grešku, prikazati poruku korisniku
        }
    } catch (error) {
        console.error('Error during login:', error);
        // Ovdje možeš obraditi eventualne greške koje su se desile tokom poziva
    }
    };

    return (
        <div className="login-container">
            <h2>Login</h2>
            <form onSubmit={handleLogin}>
                <div className="form-group">
                    <label>Email:</label>
                    <input
                        type="email"
                        value={email}
                        onChange={(e) => setEmail(e.target.value)}
                        required
                    />
                </div>
                <div className="form-group">
                    <label>Password:</label>
                    <input
                        type="password"
                        value={password}
                        onChange={(e) => setPassword(e.target.value)}
                        required
                    />
                </div>
                <button type="submit" className="btn-primary">Login</button>
            </form>
            <p className="register-link">
                Nemate nalog? <button onClick={onRegisterClick}>Registrujte se</button>
            </p>
        </div>
    );
}

export default Login;
