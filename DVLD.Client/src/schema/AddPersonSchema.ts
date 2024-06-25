import {z} from "zod"

export const AddPersonSchema = z?.object({
    FirstName:  z?.string({required_error: "FirstName Is Required"})
                  .min(2, {  message: "minLength is 2"})
                  .max(14, {message : "Maximum Length is 26 char"}),
    SecondName: z?.string({required_error: "SecondName Is Required"})
                  .min(2, {  message: "minLength is 2"})
                  .max(14, {message : "Maximum Length is 26 char"}),
    ThirdName: z?.string({required_error: "ThirdName Is Required"})
                  .min(2, {  message: "minLength is 2"})
                  .max(14, {message : "Maximum Length is 26 char"}),
    LastName: z?.string({required_error: "LastName Is Required"})
                  .min(2, {  message: "minLength is 2"})
                  .max(14, {message : "Maximum Length is 26 char"}),
    Email:    z?.string({required_error: "Email Is Required"})
                .email({message: "Invalid Email"}),
    NationalNo: z?.string({required_error: "NationalNo Is Required"}),
  
    BirthDate:  z.date().pipe(z.coerce.string()).optional(),
  
    NationalityCountryId : z.number(),
    Gender : z.union([
      z.literal("Male"),
      z.literal("Female"),
    ], {message:"Gender Is Required"}),
  
    Phone: z.string({required_error: "Phone Is Required"}),
  
    Address: z.string({required_error: "Address Is Required"})
              .min(8 , {message: "Address Length Must be More Than 8"})
              .max(40, {message: "Address Length Must be Less Than 40"}),
    Image: z.any()
            .refine((files: FileList) => {return files.length >= 1}, {message: "Photo is Required"})
  })
  