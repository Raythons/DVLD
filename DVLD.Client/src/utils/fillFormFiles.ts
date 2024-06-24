// eslint-disable-next-line @typescript-eslint/no-explicit-any
function fillFormFiles<T extends Record<string, any>>(data: T): FormData {
    const formData = new FormData();

    for (const key in data) {
    const value = data[key];

    if ((value as unknown)  instanceof File) {
        console.log(`typeof key ${key} is : ${data[key]}`)
        formData.append(key, value); // Append file directly
    } else {
        formData.append(key, value); // Convert other values to strings
        }
    }
    return formData;
}

export default fillFormFiles