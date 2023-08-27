
import AboutUsPage from "./pages/About";
import ContactUsPage from "./pages/Contactus";
import PricingPage from "./pages/Pricing";
import ServicesPage from "./pages/Services";
import Main from "./pages/Main";
import BookingPage from "./pages/Booking";
import { BrowserRouter, Route, Routes } from "react-router-dom";



function App() {
  return (
    <>
      <BrowserRouter>
        <Main>
          <Routes>
            <Route index element={<AboutUsPage />} />
            <Route path="/about" element={<AboutUsPage />} />
            <Route path="/contact" element={<ContactUsPage />} />
            <Route path="/services" element={<ServicesPage />} />
            <Route path="/price" element={<PricingPage />} />
            <Route path="/booking" element={<BookingPage />} />
          </Routes>
        </Main>
        
      </BrowserRouter>
    </>
  );
}

export default App;
