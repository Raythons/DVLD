import { useCallback } from "react";

function useLocalStorage(key: string) {
  const getItem = useCallback(() => {
    try {
      const item = localStorage.getItem(key);
      if (item) {
        return JSON.parse(item);
      }
    } catch (error) {
      console.log(error);
    }
  }, [key]);

  
  const setItem = useCallback(
    <T>(value: T) => {
      try {
        localStorage.setItem(key, JSON.stringify(value));
      } catch (error) {
        console.log(error);
      }
    },
    [key]
  );
  
  const deleteItem = useCallback(() => {
    try {
      localStorage.removeItem(key);
    } catch (error) {
      console.log(error);
    }
  }, [key]);
  return { getItem, setItem, deleteItem };
}

export default useLocalStorage;
