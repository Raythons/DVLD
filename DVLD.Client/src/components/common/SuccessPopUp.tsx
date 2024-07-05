import { Button, Modal, ModalBody } from "flowbite-react";
import { useNavigate } from "react-router-dom";

type props = {
  show:boolean
  type: string
  creationId: number| undefined,
  operation: string,
  setShowPopUp: React.Dispatch<React.SetStateAction<boolean>>
}

const SuccessPopUp = ({show, type, creationId, operation, setShowPopUp} : props) => {
  const navigate = useNavigate();
  
  
  return (
    <Modal show={show} onClose={() => setShowPopUp(!show)} >
        <Modal.Header />
        <ModalBody  >
          <div className="flex justify-center items-center flex-col w-[100%]">
              <h1 className="text-green-500 text-2xl">Success</h1>
              <p className="text-lg text-gray-700 pb-3">{type} {operation} Successfully With the Id: {creationId}</p>
              <div className="flex  justify-center items-center w-[90%]">
                  <Button color="blue" className="" onClick={() => (navigate("../.."))}>Home</Button>
              </div>
          </div>
        </ModalBody>
    </Modal>
  )
}

export default SuccessPopUp