import { useEffect, useState } from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import "/node_modules/bootstrap/dist/css/bootstrap.min.css";
import "./App.css";
import { NavBar } from "./components/Navigations/NavBar";
import { Sidebar } from "./components/Navigations/Sidebar";
import { Home } from "./pages/Home";
import { Collection } from "./pages/Collection";
import { Delivery } from "./pages/Delivery";
import { Reservation } from "./pages/Reservation";
import { Login } from "./pages/Login";
import { Register } from "./pages/Register";

function App() {
  const [forecasts, setForecasts] = useState();

  useEffect(() => {
    populateWeatherData();
  }, []);

  const contents =
    forecasts === undefined ? (
      <p>
        <em>
          Loading... Please refresh once the ASP.NET backend has started. See{" "}
          <a href="https://aka.ms/jspsintegrationreact">
            https://aka.ms/jspsintegrationreact
          </a>{" "}
          for more details.
        </em>
      </p>
    ) : (
      <table className="table table-striped" aria-labelledby="tableLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map((forecast) => (
            <tr key={forecast.date}>
              <td>{forecast.date}</td>
              <td>{forecast.temperatureC}</td>
              <td>{forecast.temperatureF}</td>
              <td>{forecast.summary}</td>
            </tr>
          ))}
        </tbody>
      </table>
    );

  return (
    <div>
      <BrowserRouter>
        <header>
          <NavBar />
        </header>
        <main>
          <Routes>
            <Route path="/" element={<Home />}></Route>
            {/* <Route path="/navbar" element={<NavBar />}></Route>*/}
            <Route path="/sidebar" element={<Sidebar />}></Route>
            <Route path="/delivery" element={<Delivery />}></Route>
            <Route path="/collection" element={<Collection />}></Route>
            <Route path="/reservation" element={<Reservation />}></Route>
            <Route path="/login" element={<Login />}></Route>
            <Route path="/register" element={<Register />}></Route>
          </Routes>
          <h1 id="tableLabel">Weather forecast</h1>
          <p>This component demonstrates fetching data from the server.</p>
          {contents}
        </main>
      </BrowserRouter>
    </div>
  );

  async function populateWeatherData() {
    const response = await fetch("weatherforecast");
    if (response.ok) {
      const data = await response.json();
      setForecasts(data);
    }
  }
}

export default App;
