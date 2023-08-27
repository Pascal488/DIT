import BG from "../assets/images/bgcarwash.jpg";
import { Link } from "react-router-dom";
import Logo from "../assets/images/logoz.png"
import SarufiChatbox from "react-sarufi-chatbox"


const Main = ({ children }: any) => {
  return (
    <div className="lg:flex h-full gap-5">
      <header className="w-full lg:w-1/2 lg:min-h-screen">
        <div
          className="lg:flex lg:justify-between lg:flex-col p-10 bg-cover bg-right-bottom lg:min-h-screen "
          style={{
            backgroundImage: `url(${BG})`,
            // position: "relative",
          }}
        >
          {/* <div
            style={{
              position: "absolute",
              top: 0,
              left: 0,
              width: "100%",
              height: "100%",
              backgroundColor: "rgba(37, 99, 235, 0.1)",
            }}
          ></div> */}
          <div className="lg:flex lg:justify-around lg:py-8 lg:px-11   xl:block ">
            <div className="justify-self-start  px-1.5">
              <span className="font cursor-pointer text-2xl text-white">
                Mobile car wash service
              </span>
            </div>

            <div className="bg-blue-600 py-2 rounded-lg px-1">
              <ul className="list-none lg:flex gap-10 cursor-pointer  text-white">
                <Link to="/services">
                  <button type="button" className="px-2 hover:bg-blue-700 hover:rounded-md">Services</button>
                </Link>
                <Link to="/about">
                  <li className="px-2 hover:bg-blue-700 hover:rounded-md">About</li>
                </Link>
                <Link to="contact">
                  <li className="px-2 hover:bg-blue-700 hover:rounded-md">Contact</li>
                </Link>
                <Link to="/price">
                  <li className="px-2 hover:bg-blue-700 hover:rounded-md">Prices</li>
                </Link>
                <Link to="/booking">
                  <li className="px-2 hover:bg-blue-700 hover:rounded-md">Booking</li>
                </Link>
              </ul>
            </div>
            <div>
              <img src="" alt="" />
            </div>
          </div>

          <img alt="" src={Logo} className="lg:w-[50%] lg:p-[4rem] w-full lg:block hidden" />
        <SarufiChatbox botId={1565} />

        </div>
      </header>
      <main className="lg:w-1/2 ">{children}</main>
    </div>
  );
};

export default Main;
