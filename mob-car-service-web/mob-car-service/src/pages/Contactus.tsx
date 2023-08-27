import React from 'react';
import Logo from "../assets/images/logoz.png"


const ContactUsPage: React.FC = () => {
  const handlesubmit = (e:any) => {
        e.prevantDefault()
  }
  return (
    <div className="container mx-auto lg:py-10 p-7">
          <div className='flex justify-center'>
          <img alt="" src={Logo} className="lg:w-[50%] -mt-[90px]" />
          </div>

      <h1 className="text-3xl font-bold text-gray-800 mb-8">Contact Us</h1>
      <div className="grid grid-cols-1 md:grid-cols-2 gap-8">
        <div className="bg-white rounded-lg shadow-md p-6">
          <h2 className="text-xl font-semibold mb-4">Contact Information</h2>
          <p className="text-gray-700">Phone: +255 789310923</p>
          <p className="text-gray-700">Email: info@carwash.com</p>
          <p className="text-gray-700">Address: Mbezi beach,Bagamoyo Road</p>
        </div>
        <div className="bg-white rounded-lg shadow-md p-6">
          <h2 className="text-xl font-semibold mb-4">Contact Form</h2>
          <form className="flex flex-col" onClick={handlesubmit}>
            <input
              type="text"
              placeholder="Your Name"
              className="border border-gray-300 rounded-lg px-4 py-2 mb-4"
            />
            <input
              type="email"
              placeholder="Your Email"
              className="border border-gray-300 rounded-lg px-4 py-2 mb-4"
            />
            <textarea
              placeholder="Message"
              rows={4}
              className="border border-gray-300 rounded-lg px-4 py-2 mb-4"
            ></textarea>
            <button type="submit" className="bg-blue-500 hover:bg-blue-600 text-white font-semibold py-2 px-4 rounded-lg">
              Send Message
            </button>
          </form>
        </div>
      </div>
    </div>
  );
};

export default ContactUsPage;
