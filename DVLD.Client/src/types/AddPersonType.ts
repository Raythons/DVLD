import {z} from "zod"
import { AddPersonSchema } from "../schema/AddPersonSchema"
import { EditPersonSchema } from "../schema/EditPersonSchema"

export type CreatePersonFormFields = z.infer< typeof AddPersonSchema>

export type EditPersonFormFields = z.infer<typeof EditPersonSchema>