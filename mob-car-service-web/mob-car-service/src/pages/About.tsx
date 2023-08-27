import React from "react";
import Paschal from "../assets/images/Faru.jpeg";
interface TeamMember {
  name: string;
  role: string;
  image: any;
}

const teamMembers: TeamMember[] = [
  {
    name: "Paschal Maximillian",
    role: "Founder & CEO",
    image: Paschal,
  },
  {
    name: "Jakobo Mjuni",
    role: "Marketing Manager",
    image: "/images/jane-smith.jpg",
  },
  {
    name: "Atuganile Mwenda",
    role: "Operations Manager",
    image: "/images/michael-johnson.jpg",
  },
];

const AboutUsPage: React.FC = () => {
  return (
    <div className="container mx-auto lg:py-10 p-10">
      <h1 className="text-3xl font-bold text-gray-800 mb-8">About Us</h1>
      <div className="grid grid-cols-1 md:grid-cols-3 gap-8">
        {teamMembers.map((member, index) => (
          <div key={index} className="bg-white rounded-lg shadow-md p-6">
            <img
              src={member.image}
              alt={member.name}
              className="h-40 object-cover mb-4 rounded-full w-h-40"
            />
            <h2 className="text-xl font-semibold mb-2">{member.name}</h2>
            <p className="text-gray-600 mb-4">{member.role}</p>
          </div>
        ))}
      </div>
      <div className="mt-12">
        <h2 className="text-2xl font-bold mb-4">Our Mission</h2>
        <h1 className="text-xl mb-3">
          Providing convenient and professional car wash services at your
          doorstep.
        </h1>

        <p className="text-gray-900 font-normal text-sm flex flex-col gap-3">
          Ujuma Mobile Car Wash Service is a leading provider of convenient and
          professional car wash services at your doorstep. With a commitment to
          excellence, we bring our expertise and state-of-the-art equipment to
          deliver exceptional results, right where you are. <br />
          <span>
          Our team of skilled professionals takes pride in delivering
          top-quality car wash services that meet the highest standards of
          professionalism. We prioritize attention to detail and ensure that
          every vehicle we touch receives the utmost care and meticulous 
          cleaning.

          </span>
          <span>

          Choose Ujuma Mobile Car Wash Service for a reliable and convenient car
          wash experience that exceeds your expectations. We are dedicated to
          delivering unmatched customer satisfaction and maintaining the highest
          level of professionalism in every interaction.
          </span>
        </p>
      </div>
    </div>
  );
};

export default AboutUsPage;
