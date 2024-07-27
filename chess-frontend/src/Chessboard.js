import React from 'react';
import './Chessboard.css';

const Piece = ({ type, color }) => {
    const pieceClass = `${color}-${type}`;
    return <div className={`piece ${pieceClass}`}></div>;
};

const Chessboard = ({ pieces }) => {
    console.log('Pieces:', pieces); // Debugging line

    const renderSquare = (i, j) => {
        const isBlack = (i + j) % 2 === 1;
        const piece = pieces.find(p => p.row === i && p.col === j);
        return (
            <div
                key={`${i}-${j}`}
                className={`square ${isBlack ? 'black' : 'white'}`}
            >
                {piece && <Piece type={piece.type} color={piece.color} />}
            </div>
        );
    };

    const renderRow = (i) => {
        const squares = [];
        for (let j = 0; j < 8; j++) {
            squares.push(renderSquare(i, j));
        }
        return (
            <div key={i} className="row">
                {squares}
            </div>
        );
    };

    const renderBoard = () => {
        const rows = [];
        for (let i = 0; i < 8; i++) {
            rows.push(renderRow(i));
        }
        return <div className="board">{rows}</div>;
    };

    return (
        <div className="chessboard-container">
            {renderBoard()}
        </div>
    );
};

export default Chessboard;
