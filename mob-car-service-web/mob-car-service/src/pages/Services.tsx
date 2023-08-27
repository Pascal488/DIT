import React from 'react';
import Logo from "../assets/images/logoz.png"
import { Link } from 'react-router-dom';

interface Service {
  title: string;
  description: string;
  price: number;
  features: string[];
}

const services: Service[] = [
  {
    title: 'Exterior Wash',
    description: 'Thorough cleaning of the car exterior, including body, windows, and tires.',
    price: 25,
    features: ['High-quality car shampoo', 'Hand drying for a spotless finish'],
  },
  {
    title: 'Interior Cleaning',
    description: 'Complete cleaning of the car interior, including vacuuming and wipe-down.',
    price: 35,
    features: ['Vacuuming of carpets and seats', 'Cleaning of dashboard and door panels'],
  },
  {
    title: 'Deluxe Package',
    description: 'Comprehensive car wash service, including exterior wash and interior cleaning.',
    price: 50,
    features: [
      'Exterior wash with wax coating',
      'Interior vacuuming and cleaning',
      'Tire shining',
    ],
  },
];

const ServicesPage: React.FC = () => {
  return (
    <div className="container mx-auto lg:py-10 p-10">
          <div className='flex justify-center lg:-mt-[110px]'>
          <img alt="" src={Logo} className="lg:w-[50%] " />
          </div>
      <h1 className="text-3xl font-bold text-gray-800 mb-8">Our Services</h1>
      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8">
        {services.map((service, index) => (
          <div key={index} className="bg-white rounded-lg shadow-md p-3">
            <h2 className="text-xl font-semibold mb-4">{service.title}</h2>
            <p className="text-gray-600 mb-4">{service.description}</p>
            <div className="flex flex-col">
              {service.features.map((feature, index) => (
                <p key={index} className="flex items-center text-gray-500 mb-2">
                  <svg
                    xmlns="http://www.w3.org/2000/svg"
                    className="h-4 w-4 mr-2 text-blue-500"
                    viewBox="0 0 20 20"
                    fill="currentColor"
                  >
                    <path
                      fillRule="evenodd"
                      d="M10 3a7 7 0 100 14 7 7 0 000-14zM7 9a1 1 0 112 0 1 1 0 01-2 0zm4-2a1 1 0 100 2 1 1 0 000-2z"
                      clipRule="evenodd"
                    />
                  </svg>
                  {feature}
                </p>
              ))}
            </div>
            <p className="text-2xl font-bold mt-6">${service.price}</p>
            <Link to="/booking">
            <button className="bg-blue-500 hover:bg-blue-600 text-white font-semibold py-2 px-4 mt-4 rounded-lg">
              Book Now
            </button>
            </Link>
          </div>
        ))}
      </div>
    </div>
  );
};

export default ServicesPage;
