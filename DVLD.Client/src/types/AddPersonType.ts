import {z} from "zod"
import { AddPersonSchema } from "../schema/AddPersonSchema"

export type CreatePersonFormFields = z.infer< typeof AddPersonSchema>
