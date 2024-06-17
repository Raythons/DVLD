 const  isObjectEmpty = (e: object | undefined) => {
    if (typeof e !== "object") return true;
    return Object.keys(e).length === 0;
  };

 export default isObjectEmpty