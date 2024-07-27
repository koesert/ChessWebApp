import React, { useState, useEffect } from 'react';
import Chessboard from './Chessboard';
import './App.css';

function App() {
    const [pieces, setPieces] = useState([]);

    useEffect(() => {
        fetch('http://localhost:5286/api/chess/initial') // Updated URL
            .then(response => response.json())
            .then(data => setPieces(data))
            .catch(error => console.error('Error fetching pieces:', error));
    }, []);

    return (
        <div className="App">
            <Chessboard pieces={pieces} />
        </div>
    );
}

export default App;
