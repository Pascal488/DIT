import React from 'react';
import Logo from "../assets/images/logoz.png"

interface Package {
  title: string;
  price: number;
  services: string[];
}

const packages: Package[] = [
  {
    title: 'Basic Package',
    price: 25,
    services: ['Exterior Wash', 'Interior Vacuuming'],
  },
  {
    title: 'Standard Package',
    price: 40,
    services: ['Exterior Wash', 'Interior Vacuuming', 'Dashboard Cleaning'],
  },
  {
    title: 'Premium Package',
    price: 60,
    services: ['Exterior Wash', 'Interior Vacuuming', 'Dashboard Cleaning', 'Tire Shining'],
  },
];

const additionalServices: string[] = ['Wax Coating', 'Seat Shampooing', 'Odor Removal'];

const PricingPage: React.FC = () => {
  return (
    <div className="container mx-auto lg:py-10 p-10">
         <div className='flex justify-center lg:-mt-[110px]'>
          <img alt="" src={Logo} className="lg:w-[50%] " />
          </div>
      <h1 className="text-3xl font-bold text-gray-800 mb-4">Pricing</h1>
      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-5">
        {packages.map((pkg, index) => (
          <div key={index} className="bg-white rounded-lg shadow-md p-5">
            <h2 className="text-xl font-semibold mb-4">{pkg.title}</h2>
            <p className="text-2xl font-bold text-gray-800 mb-4">${pkg.price}</p>
            <ul className="list-disc list-inside mb-6">
              {pkg.services.map((service, index) => (
                <li key={index} className="text-gray-600">
                  {service}
                </li>
              ))}
            </ul>
          </div>
        ))}
      </div>
      <div className="mt-12">
        <h2 className="text-2xl font-bold mb-3">Additional Services</h2>
        <ul className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-4">
          {additionalServices.map((service, index) => (
            <li key={index} className="bg-white rounded-lg shadow-md p-4 text-gray-600">
              {service}
            </li>
          ))}
        </ul>
      </div>
    </div>
  );
};

export default PricingPage;
