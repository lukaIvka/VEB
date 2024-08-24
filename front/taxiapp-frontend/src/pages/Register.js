import React, { useState } from 'react';
import '../styles/Register.css';

function Register({ onLoginClick }) {
    const [user, setUser] = useState({
        userName: '',
        email: '',
        password: '',
        name: '',
        lastname: '',
        type:'',
        dateOfBirth: '',
        address: '',
        picture: ''
    });

    const handleChange = (e) => {
        setUser({ ...user, [e.target.name]: e.target.value });
        setType({ ...type, [e.target.name]: e.target.value });
    };
    const [type, setType] = useState('User');

    const handleRegister = async (e) => {
        e.preventDefault();
        // Ovdje dodaj logiku za registraciju

        if (!user.userName || !user.email || !user.password || !user.name || !user.lastname || !user.dateOfBirth || !user.address) {
            alert('Sva polja su obavezna, osim profilne slike.');
            return;
        }
    
        const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        if (!emailRegex.test(user.email)) {
            alert('Unesite ispravan email.');
            return;
        }

        try {
            const response = await fetch('http://localhost:8487/api/auth/register', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(user)
            });

            if (response.ok) {
                const data = await response.json();
                console.log('Registration successful:', data);
                onLoginClick();
                // Ovdje možeš obraditi dobijene podatke, kao što je preusmeravanje korisnika na login stranicu
            } else {
                console.log('Registration failed:', response.statusText);
                // Ovdje možeš obraditi grešku, prikazati poruku korisniku
            }
        } catch (error) {
            console.error('Error during registration:', error);
            // Ovdje možeš obraditi eventualne greške koje su se desile tokom poziva
        }
    };

    return (
        <div className="register-container">
            <h2>Registracija</h2>
            <form onSubmit={handleRegister}>
                <div className="form-group">
                    <label>Korisničko ime:</label>
                    <input
                        type="text"
                        name="userName"
                        value={user.userName}
                        onChange={handleChange}
                        required
                    />
                </div>
                <div className="form-group">
                    <label>Email:</label>
                    <input
                        type="email"
                        name="email"
                        value={user.email}
                        onChange={handleChange}
                        required
                    />
                </div>
                <div className="form-group">
                    <label>Lozinka:</label>
                    <input
                        type="password"
                        name="password"
                        value={user.password}
                        onChange={handleChange}
                        required
                    />
                </div>
                <div className="form-group">
                    <label>Ime:</label>
                    <input
                        type="text"
                        name="name"
                        value={user.name}
                        onChange={handleChange}
                        required
                    />
                </div>
                <div className="form-group">
                    <label>Prezime:</label>
                    <input
                        type="text"
                        name="lastname"
                        value={user.lastname}
                        onChange={handleChange}
                        required
                    />
                </div>
                <div className="form-group">
                    <label>Tip korisnika:</label>
                    <select value={user.type} onChange={(e) => setType(e.target.value)}
                        required name = "type">
                        <option value="Admin">Admin</option>
                        <option value="User">User</option>
                        <option value="Driver">Driver</option>
                    </select>
                </div>
                <div className="form-group">
                    <label>Datum rođenja:</label>
                    <input
                        type="date"
                        name="dateOfBirth"
                        value={user.dateOfBirth}
                        onChange={handleChange}
                        required
                    />
                </div>
                <div className="form-group">
                    <label>Adresa:</label>
                    <input
                        type="text"
                        name="address"
                        value={user.address}
                        onChange={handleChange}
                        required
                    />
                </div>
                <div className="form-group">
                    <label>Profilna slika (URL):</label>
                    <input
                        type="text"
                        name="picture"
                        value={user.picture}
                        onChange={handleChange}
                    />
                </div>
                <button type="submit" className="btn-primary">Registracija</button>
            </form>
            <p className="login-link">
                Već imate nalog? <button onClick={onLoginClick}>Prijavite se</button>
            </p>
        </div>
    );
}

export default Register;
