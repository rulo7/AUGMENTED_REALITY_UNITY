<?php

namespace AppBundle\Controller\Api;

use AppBundle\Form\UsersType;
use FOS\RestBundle\Controller\FOSRestController;
use AppBundle\Entity\Users;
use Symfony\Component\HttpFoundation\Request;
use FOS\RestBundle\Controller\Annotations\View;

class UsersRestController extends FOSRestController
{

    /**
     * @View()
     */
    public function getUsersAction()
    {
        $em = $this->getDoctrine()->getManager();

        //$users = $em->getRepository('AppBundle:Users')->findAll();
        $users = $em->getRepository('AppBundle:Users')->findBy(
            array(),
            array('score' => 'DESC')
        );

        return array(
            'users' => $users
        );
    }

    /**
     * @View()
     */
    public function getUserAction($id)
    {
        $em = $this->getDoctrine()->getManager();

        $user = $em->getRepository('AppBundle:Users')->find($id);

        return array(
            'user' => $user
        );
    }

    /**
     * @View()
     */
    public function postUserAction(Request $request)
    {
        $user = new Users();
        $form = $this->createForm(new UsersType(), $user);
        $form->submit($request);

        if ($form->isValid()) {
            $em = $this->getDoctrine()->getManager();
            $em->persist($user);
            $em->flush();
        }

        return array(
            'form' => $form
        );
    }
}
