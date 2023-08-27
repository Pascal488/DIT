import { useMutation } from "@apollo/client";
import React, { useState } from "react";
import { BOOKING } from "../graphql/Mutations";

const BookingPage: React.FC = () => {
  const [errorz, setErrorz] = useState("");
  const initialValues = {
    date: "",
    time: "",
    location: "",
    services: "",
    descriptions: "",
    name: "",
    email: "",
    phonenumber: "",
  }
  const [values, setValues] = useState(initialValues);

  const onchange = (e: any) => {
    setValues({
      ...values,
      [e.target.name]: e.target.value,
    });
  };
  const [Book] = useMutation(BOOKING);

  const handleSubmit = (event: React.FormEvent) => {
    event.preventDefault();
    if(!values.date || !values.descriptions || !values.email || !values.location || !values.name || !values.phonenumber || !values.services || !values.time){
      setErrorz("Enter all the fields required")
    }else{
      setErrorz("")
    }
    Book({
      variables: {
        ...values,
      },
      onError(error) {
        setErrorz("Please enter all the values required ");
        console.log(error);
      },
      onCompleted(data) {
       setValues(initialValues)
        console.log(data);
        alert("Booking successed")
      },
    });
  };

  return (
    <div className="container mx-auto lg:py-10 p-7">
      <h1 className="text-3xl font-bold text-gray-800 mb-8">
        Book a car wash service appointment
      </h1>
      <div className="flex gap-5 items-center">
        <div
          className="w-32 h-32 rounded-full bg-blue-600 "
          style={{
            backgroundImage:
              "url('https://images.pexels.com/photos/6873088/pexels-photo-6873088.jpeg?auto=compress&cs=tinysrgb&w=800')",
            backgroundSize: "cover",
          }}
        ></div>
        <div
          className="w-32 h-32 rounded-full bg-blue-600 "
          style={{
            backgroundImage:
              "url('https://images.pexels.com/photos/6872148/pexels-photo-6872148.jpeg?auto=compress&cs=tinysrgb&w=800')",
            backgroundSize: "cover",
          }}
        ></div>
        <div
          className="w-32 h-32 rounded-full bg-blue-600 "
          style={{
            backgroundImage:
              "url('https://images.pexels.com/photos/4876652/pexels-photo-4876652.jpeg?auto=compress&cs=tinysrgb&w=800')",
            backgroundSize: "cover",
          }}
        ></div>
      </div>
      <form onSubmit={handleSubmit} className="p-3">
        <div className="grid grid-cols-1 md:grid-cols-2 gap-8">
          <div>
            <label
              htmlFor="date"
              className="block text-gray-700 font-semibold mb-2"
            >
              Date
            </label>
            <input
              type="date"
              id="date"
              name="date"
              className="w-full rounded-lg border-gray-300 focus:border-blue-500 focus:ring-blue-500 border-[0.8px] px-2 py-2"
              value={values.date}
              onChange={onchange}
            />
          </div>
          <div>
            <label
              htmlFor="time"
              className="block text-gray-700 font-semibold mb-2"
            >
              Time
            </label>
            <input
              type="time"
              id="time"
              name="time"
              className="w-full rounded-lg border-gray-300 focus:border-blue-500 focus:ring-blue-500 border-[0.8px] px-2 py-2"
              value={values.time}
              onChange={onchange}
            />
          </div>
          <div>
            <label
              htmlFor="location"
              className="block text-gray-700 font-semibold mb-2"
            >
              Location
            </label>
            <input
              type="text"
              id="location"
              name="location"
              className="w-full rounded-lg border-gray-300 focus:border-blue-500 focus:ring-blue-500 border-[0.8px] px-2 py-2"
              placeholder="Enter your location"
              value={values.location}
              onChange={onchange}
            />
          </div>

          <div>
            <label
              htmlFor="name"
              className="block text-gray-700 font-semibold mb-2"
            >
              Name
            </label>
            <input
              type="text"
              id="name"
              name="name"
              className="w-full rounded-lg border-gray-300 focus:border-blue-500 focus:ring-blue-500 border-[0.8px] px-2 py-2"
              placeholder="Enter your name"
              value={values.name}
              onChange={onchange}
            />
          </div>
          <div>
            <label
              htmlFor="email"
              className="block text-gray-700 font-semibold mb-2"
            >
              Email
            </label>
            <input
              type="email"
              id="email"
              name="email"
              className="w-full rounded-lg border-gray-300 focus:border-blue-500 focus:ring-blue-500 border-[0.8px] px-2 py-2"
              placeholder="Enter your email"
              value={values.email}
              onChange={onchange}
            />
          </div>

          <div>
            <label
              htmlFor="phone"
              className="block text-gray-700 font-semibold mb-2"
            >
              Phone
            </label>
            <input
              type="tel"
              id="phonenumber"
              name="phonenumber"
              className="w-full rounded-lg border-gray-300 focus:border-blue-500 focus:ring-blue-500 border-[0.8px] px-2 py-2"
              placeholder="Enter your phone number"
              value={values.phonenumber}
              onChange={onchange}
            />
          </div>
          <div>
            <label
              htmlFor="instructions"
              className="block text-gray-700 font-semibold mb-2"
            >
              Instructions
            </label>
            <textarea
              id="descriptions"
              name="descriptions"
              className="w-full rounded-lg border-gray-300 focus:border-blue-500 focus:ring-blue-500 border-[0.8px] px-2 py-2"
              placeholder="Enter any additional instructions or requirements"
              value={values.descriptions}
              onChange={onchange}
            />
          </div>
          <div>
            <label
              htmlFor="services"
              className="block text-gray-700 font-semibold mb-2"
            >
              Services
            </label>
            <textarea
              id="services"
              name="services"
              className="w-full rounded-lg border-gray-300 focus:border-blue-500 focus:ring-blue-500 border-[0.8px] px-2 py-2"
              placeholder="Enter the services you require"
              value={values.services}
              onChange={onchange}
            />
          </div>
        </div>
        {errorz && (
          <div className="text-xs text-red-600 mt-5 ml-2">{errorz}</div>
        )}
        <button
          type="submit"
          className="bg-blue-500 hover:bg-blue-600 text-white font-semibold py-2 px-4 mt-6 rounded-lg"
        >
          Book now
        </button>
      </form>
    </div>
  );
};

export default BookingPage;
