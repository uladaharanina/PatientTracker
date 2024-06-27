import React from 'react';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import logo from './logo.svg';
import './App.css';
import { Home } from './LayoutComponents/Home';
import { Dashboard } from './LayoutComponents/Dashboard';

function App() {
  return (
    <BrowserRouter>
    <Routes>
      <Route path="/" element={<Home />}></Route>
      <Route path="/dashboard" element={<Dashboard />}></Route>

    </Routes>
  </BrowserRouter>

  );
}

export default App;
