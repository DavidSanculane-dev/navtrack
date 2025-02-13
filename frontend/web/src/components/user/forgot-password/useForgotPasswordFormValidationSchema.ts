import { object, SchemaOf, string } from "yup";
import { ForgotPasswordFormValues } from "./ForgotPasswordFormValues";

export const useForgotPasswordFormValidationSchema = () => {
  const validationSchema: SchemaOf<ForgotPasswordFormValues> = object({
    email: string()
      .email("generic.email.valid")
      .required("generic.email.required")
      .defined(),
  }).defined();

  return validationSchema;
};
