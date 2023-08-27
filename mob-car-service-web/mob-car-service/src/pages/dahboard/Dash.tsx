import React from 'react';
import Table from '../../components/Table';

const DashboardPage: React.FC = () => {
  const data = [
    {
      "id": "647281419ccda691df3ea5ac",
      "date": "2023-05-28",
      "name": "John Doe",
      "descriptions": "Appointment for car wash",
      "services": "Exterior wash",
      "email": "johndoe@example.com",
      "phonenumber": "1234567890",
      "location": "123 Main Street",
      "time": "10:00 AM"
    },
    // Add more data objects as needed
  ];
  return (
    <div className="container mx-auto py-10">
      <h1 className="text-3xl font-bold text-gray-800 mb-8">Dashboard</h1>
      <div className="grid grid-cols-1 md:grid-cols-3 gap-8">
        <div className="bg-white rounded-lg shadow-md p-6">
          <h2 className="text-xl font-semibold mb-4">Bookings</h2>
        </div>
        <div className="bg-white rounded-lg shadow-md p-6">
          <h2 className="text-xl font-semibold mb-4">Customers</h2>
        </div>
        <div className="bg-white rounded-lg shadow-md p-6">
          <h2 className="text-xl font-semibold mb-4">Performance Metrics</h2>
        </div>
      </div>
      <div className="mt-12">
        <h2 className="text-2xl font-bold mb-4">Service Management</h2>
      </div>


      <h1>Appointment Table</h1>
      <Table data={data} />
    </div>
  );
};

export default DashboardPage;
