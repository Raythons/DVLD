import { Button, Modal, ModalBody } from "flowbite-react";
import { useNavigate } from "react-router-dom";

type props = {
  show:boolean
  type: string
  creationId: number| undefined
  setShowPopUp: React.Dispatch<React.SetStateAction<boolean>>
}

const SuccessPopUp = ({show, type, creationId, setShowPopUp} : props) => {
  const navigate = useNavigate();

  return (
    <Modal show={show} onClose={() => setShowPopUp(!show)} >
        <Modal.Header />
        <ModalBody  >
          <div className="flex justify-center items-center flex-col w-[100%]">
              <h1 className="text-green-500 text-2xl">Success</h1>
              <p className="text-lg text-gray-700 pb-3">{type} Created Successfully With the Id: {creationId}</p>
              <div className="flex  justify-between items-center w-[90%]">
                  <Button color="blue" className="" onClick={() => (navigate("../.."))}>Home</Button>
                  <Button color="blue" onClick={() => (window.location.reload())} >Add More</Button>
              </div>
          </div>
        </ModalBody>
    </Modal>
  )
}

export default SuccessPopUp