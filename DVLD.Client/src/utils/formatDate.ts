export function format(inputDate: Date) {
  
    const date = inputDate.getDate();
    const month = inputDate.getMonth() + 1;
    const year = inputDate.getFullYear();
  
    // date = date.toString().padStart(2, '0');
    // month = month.toString().padStart(2, '0');
  
    return `${date}/${month}/${year}`;
}