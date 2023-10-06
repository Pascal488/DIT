import { Appointment } from "../models/appointment.js";
import mongoose from "mongoose";

export const appointmentsResolvers = {
  Query: {
    appointments: async() => {
          try{
            const appointment = await Appointment.find({}).sort({createdAt:-1});
            return appointment.map((booking)=>{
              return{
                id:booking.id,
                date:booking.date,
                name:booking.name,
                descriptions:booking.descriptions,
                services:booking.services,
                email:booking.email,
                phonenumber:booking.phonenumber,
                location:booking.location,
                time:booking.time,
                createdAt:booking.createdAt
              }
            })

          }catch(error){
            console.log(error)
          }
    }
  },
  Mutation: {
    createAppointment: async (_, args) => {
      const {
        date,
        name,
        descriptions,
        services,
        email,
        phonenumber,
        location,
        time
      } = args;
      try {
        if (!args) {
          throw new Error("Please fill all fields");
        }
        const newAppointment = new Appointment({
          date,
          name,
          descriptions,
          services,
          email,
          phonenumber,
          location,
          time,
          createdAt: new Date().toISOString()
        });
        const result = await newAppointment.save();
        return result;
      } catch (error) {
        console.log('Error on creating an appointment: ', error);
        console.log("Here is error", error);
      }
    }
  }
};
