import { UseFormRegister } from 'react-hook-form';
import { EditPersonFormFields } from '../../types/AddPersonType';
import { useGetAllCountriesQuery } from '../../redux/api/countriesApi';


type props = {
    id: string,
    errorMessage: string | undefined,
    defaultCountryId: number | undefined,
    register: UseFormRegister<EditPersonFormFields>
    
}
const CountriesInput = ({id, errorMessage, defaultCountryId, register} : props) => {
    const {data : Countries , isSuccess: isCountriesSuccess  } = useGetAllCountriesQuery({});

    return (
        <>
            <label htmlFor={id} className="">Country:</label>
                    <select
                    defaultValue={defaultCountryId}
                    {...register("NationalityCountryId", {valueAsNumber: true})}  id={id} 
                      title= "countries"  className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500">
                      {
                        isCountriesSuccess &&   Countries?.map((country) => {
                            return (
                              <option 
                                defaultChecked={country.Id === defaultCountryId}
                                key={country.Id}
                                defaultValue={country.Id}
                                value={country.Id}
                                >
                                  {country.CountryName}
                                </option>
                            )
                        })
                      }
                    </select>
                    {errorMessage && <span className="text-red-700 absolute top-11 whitespace-nowrap">{errorMessage}</span>}
        </>
    )
}

export default CountriesInput