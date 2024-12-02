import React from "react";
import "./HomePage.css";
import { useNavigate } from "react-router-dom";

function HomePage() {
    const navigate = useNavigate();
    return (
        <div className="homepage">
            {/* Navigatiebalk */}
            <nav className="navbar">
                <div className="logo">CarsAndAll</div>
                <ul className="nav-links">
                    <li><a href="#home">Home</a></li>
                    <li><a href="#about">Over Ons</a></li>
                    <li><a href="#subscriptions">Abonnementen</a></li>
                    <li><a href="#contact">Contact</a></li>
                </ul>
                <div className="auth-buttons">
                    <button onClick={() => navigate('/login', {replace: true})}  className="login-btn">Inloggen</button>
                    <button onClick={() => navigate('/register', {replace: true})}  className="register-btn">Registreren</button>
                </div>
            </nav>

            {/* Hero sectie */}
            <header className="hero">
                <h1>Welkom bij CarsAndAll</h1>
                <p>Huur eenvoudig auto's als particulier of zakelijk.</p>
                <div className="cta-buttons">
                    <button>Bekijk Abonnementen</button>
                    <button>Boek Nu</button>
                </div>
            </header>

            {/* Sectie voor diensten */}
            <section className="services">
                <h2>Onze Diensten</h2>
                <div className="service-list">
                    <div className="service">
                        <h3>Huur voor Particulieren</h3>
                        <p>Betaalbare en flexibele autohuur voor dagelijks gebruik.</p>
                    </div>
                    <div className="service">
                        <h3>Huur voor Bedrijven</h3>
                        <p>Professionele autoverhuur voor jouw zakelijke behoeften.</p>
                    </div>
                </div>
            </section>

            {/* Footer */}
            <footer className="footer">
                <p>&copy; 2024 CarsAndAll. Alle rechten voorbehouden.</p>
                <ul className="footer-links">
                    <li><a href="#privacy">Privacybeleid</a></li>
                    <li><a href="#terms">Gebruiksvoorwaarden</a></li>
                </ul>
            </footer>
        </div>
    );
}

export default HomePage;
