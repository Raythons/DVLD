import { Button, Modal, ModalBody } from 'flowbite-react'
import React from 'react'

type deletePopUpProps = {
    show:boolean
    type: string
    deletionId: number
    setShowPopUp: React.Dispatch<React.SetStateAction<boolean>>,
}

const DeletePopUp = ({show, type, deletionId, setShowPopUp} : deletePopUpProps) => {

    return (
        <Modal show={show} onClose={() => setShowPopUp(!show)} >
            <Modal.Header />
                <ModalBody  >
                    <div className="flex justify-center items-center flex-col w-[100%]">
                        <h1 className="text-rose-500 text-2xl">Warning</h1>
                        <p className="text-lg text-gray-700 pb-3"> Do You Want To Delete {type} With of Id: {deletionId}</p>
                        <div className="flex  justify-between items-center w-[90%]">
                            <Button color="blue" className="" onClick={() => setShowPopUp(!show)}>cancel</Button>
                            <Button color="red" onClick={() => (window.location.reload())} >Delete</Button>
                        </div>
                    </div>
                </ModalBody>
        </Modal>
    )
}

export default DeletePopUp