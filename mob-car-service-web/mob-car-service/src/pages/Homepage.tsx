import React from 'react';
import BG from "../assets/images/img-dropbox-bg.svg"
const HomePage: React.FC = () => {
  return (
    <div
    className="p-5 bg-blue-500   text-white mb-5 "
    style={{
      backgroundImage:`url(${BG})`,
      backgroundRepeat: "no-repeat",
      backgroundSize: "cover",
      height:"100%",
    }}
  >
    <div className="flex justify-around ">
      <div className="justify-self-start">
        <span className="font-semiblod cursor-pointer">Mobile car wash service</span>
      </div>

      <div>
        <ul className="list-none flex gap-10 cursor-pointer text-black">
            <li>Services</li>
            <li>About Us</li>
            <li>Contact</li>
        </ul>
      </div>
      <div>
        <img src="" alt="" />
      </div>
    </div>

    <div className="text-center p-10 ">
      <div className="text-2xl lg:text-5xl font-semibold">
        <span className="block">    Providing conv<span className='text-black'>enient and professional </span> </span>
        <span className="block text-black">car wash service at your doorstep</span>
      </div>
      <div className="p-10">
      </div>
    </div>
    
  </div>
  );
};

export default HomePage;
