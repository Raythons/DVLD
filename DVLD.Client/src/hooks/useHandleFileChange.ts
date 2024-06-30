
export const  useHandleFileChange = () => {
    
    const handleFileChanges = (e:React.ChangeEvent<HTMLInputElement>, setter: React.Dispatch<React.SetStateAction<string>>) => {
            const selectedFile = e.target.files?.item(0);
            console.log("itwpokred ");
            
            if (selectedFile) {
              const reader = new FileReader();
              reader.readAsDataURL(selectedFile); 
        
              reader.onloadend = () => {
                setter(reader.result as string); 
              };
          }
    }
    return {handleFileChanges}
  };